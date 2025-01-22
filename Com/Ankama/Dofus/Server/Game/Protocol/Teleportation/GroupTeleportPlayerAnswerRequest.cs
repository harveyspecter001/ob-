using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000089 RID: 137
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupTeleportPlayerAnswerRequest : IMessage<GroupTeleportPlayerAnswerRequest>, IMessage, IEquatable<GroupTeleportPlayerAnswerRequest>, IDeepCloneable<GroupTeleportPlayerAnswerRequest>, IBufferMessage
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0018BBD8 File Offset: 0x00189DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupTeleportPlayerAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0018BBE8 File Offset: 0x00189DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0018BBF8 File Offset: 0x00189DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0018BC08 File Offset: 0x00189E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerAnswerRequest()
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0018BC18 File Offset: 0x00189E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerAnswerRequest(GroupTeleportPlayerAnswerRequest other)
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0018BC28 File Offset: 0x00189E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0018BC38 File Offset: 0x00189E38
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0018BC48 File Offset: 0x00189E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accept
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0018BC58 File Offset: 0x00189E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0018BC68 File Offset: 0x00189E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GroupTeleportPlayerAnswerRequest other)
		{
			return true;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0018BC78 File Offset: 0x00189E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0018BC88 File Offset: 0x00189E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0018BC98 File Offset: 0x00189E98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0018BCA8 File Offset: 0x00189EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0018BCB8 File Offset: 0x00189EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0018BCC8 File Offset: 0x00189EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GroupTeleportPlayerAnswerRequest other)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0018BCD8 File Offset: 0x00189ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0018BCE8 File Offset: 0x00189EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0018BCF8 File Offset: 0x00189EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GroupTeleportPlayerAnswerRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					GroupTeleportPlayerAnswerRequest._parser = new MessageParser<GroupTeleportPlayerAnswerRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0018BDDC File Offset: 0x00189FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p233GnOKuQB0ZPD9t3IJ()
		{
			return true;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0018BDE4 File Offset: 0x00189FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GroupTeleportPlayerAnswerRequest rYywJvOK8NjCloUXngXM()
		{
			return null;
		}

		// Token: 0x0400021C RID: 540
		private static readonly MessageParser<GroupTeleportPlayerAnswerRequest> _parser;

		// Token: 0x0400021D RID: 541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400021E RID: 542
		public const int AcceptFieldNumber = 1;

		// Token: 0x0400021F RID: 543
		private bool accept_;

		// Token: 0x04000220 RID: 544
		internal static GroupTeleportPlayerAnswerRequest pNuq5QOKMZlZNiHjkEpZ;
	}
}
