using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C8F RID: 3215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterRenameRequest : IMessage<CharacterRenameRequest>, IMessage, IEquatable<CharacterRenameRequest>, IDeepCloneable<CharacterRenameRequest>, IBufferMessage
	{
		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06009A7E RID: 39550 RVA: 0x0027D0B4 File Offset: 0x0027B2B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterRenameRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06009A7F RID: 39551 RVA: 0x0027D0C4 File Offset: 0x0027B2C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06009A80 RID: 39552 RVA: 0x0027D0D4 File Offset: 0x0027B2D4
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

		// Token: 0x06009A81 RID: 39553 RVA: 0x0027D0E4 File Offset: 0x0027B2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRenameRequest()
		{
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x0027D0F4 File Offset: 0x0027B2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRenameRequest(CharacterRenameRequest other)
		{
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x0027D104 File Offset: 0x0027B304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRenameRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06009A84 RID: 39556 RVA: 0x0027D114 File Offset: 0x0027B314
		// (set) Token: 0x06009A85 RID: 39557 RVA: 0x0027D124 File Offset: 0x0027B324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x0027D134 File Offset: 0x0027B334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x0027D144 File Offset: 0x0027B344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterRenameRequest other)
		{
			return true;
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x0027D154 File Offset: 0x0027B354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x0027D164 File Offset: 0x0027B364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x0027D174 File Offset: 0x0027B374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x0027D184 File Offset: 0x0027B384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x0027D194 File Offset: 0x0027B394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x0027D1A4 File Offset: 0x0027B3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterRenameRequest other)
		{
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x0027D1B4 File Offset: 0x0027B3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x0027D1C4 File Offset: 0x0027B3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x0027D1D4 File Offset: 0x0027B3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterRenameRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					CharacterRenameRequest._parser = new MessageParser<CharacterRenameRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x0027D2A0 File Offset: 0x0027B4A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lV6qKxJxEp0Z5hyP0OxB()
		{
			return true;
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x0027D2A8 File Offset: 0x0027B4A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterRenameRequest heKIIjJxX3jrekXrSQwF()
		{
			return null;
		}

		// Token: 0x0400394E RID: 14670
		private static readonly MessageParser<CharacterRenameRequest> _parser;

		// Token: 0x0400394F RID: 14671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003950 RID: 14672
		public const int NameFieldNumber = 1;

		// Token: 0x04003951 RID: 14673
		private string name_;

		// Token: 0x04003952 RID: 14674
		private static CharacterRenameRequest BB4ncHJx21mo3AJ518oQ;
	}
}
