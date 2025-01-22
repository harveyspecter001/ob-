using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000081 RID: 129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ZaapRespawnSaveRequest : IMessage<ZaapRespawnSaveRequest>, IMessage, IEquatable<ZaapRespawnSaveRequest>, IDeepCloneable<ZaapRespawnSaveRequest>, IBufferMessage
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0018B3D8 File Offset: 0x001895D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ZaapRespawnSaveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0018B3E8 File Offset: 0x001895E8
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0018B3F8 File Offset: 0x001895F8
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

		// Token: 0x0600052C RID: 1324 RVA: 0x0018B408 File Offset: 0x00189608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapRespawnSaveRequest()
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0018B418 File Offset: 0x00189618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapRespawnSaveRequest(ZaapRespawnSaveRequest other)
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0018B428 File Offset: 0x00189628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapRespawnSaveRequest Clone()
		{
			return null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0018B438 File Offset: 0x00189638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0018B448 File Offset: 0x00189648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ZaapRespawnSaveRequest other)
		{
			return true;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0018B458 File Offset: 0x00189658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0018B468 File Offset: 0x00189668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0018B478 File Offset: 0x00189678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0018B488 File Offset: 0x00189688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0018B498 File Offset: 0x00189698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0018B4A8 File Offset: 0x001896A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ZaapRespawnSaveRequest other)
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0018B4B8 File Offset: 0x001896B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0018B4C8 File Offset: 0x001896C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0018B4D8 File Offset: 0x001896D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ZaapRespawnSaveRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
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
					ZaapRespawnSaveRequest._parser = new MessageParser<ZaapRespawnSaveRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0018B5BC File Offset: 0x001897BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bs0VW2OKwYa2ZgR4Vd0d()
		{
			return true;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0018B5C4 File Offset: 0x001897C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ZaapRespawnSaveRequest HLMcB5OKQRJ2EfvUF2PF()
		{
			return null;
		}

		// Token: 0x04000202 RID: 514
		private static readonly MessageParser<ZaapRespawnSaveRequest> _parser;

		// Token: 0x04000203 RID: 515
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000204 RID: 516
		internal static ZaapRespawnSaveRequest e6VOWCOKt7nJ3dUxVIqj;
	}
}
