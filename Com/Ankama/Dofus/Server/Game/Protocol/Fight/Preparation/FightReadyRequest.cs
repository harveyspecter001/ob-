using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006A1 RID: 1697
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightReadyRequest : IMessage<FightReadyRequest>, IMessage, IEquatable<FightReadyRequest>, IDeepCloneable<FightReadyRequest>, IBufferMessage
	{
		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x060052C0 RID: 21184 RVA: 0x00208D98 File Offset: 0x00206F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightReadyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x060052C1 RID: 21185 RVA: 0x00208DA8 File Offset: 0x00206FA8
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

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x060052C2 RID: 21186 RVA: 0x00208DB8 File Offset: 0x00206FB8
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

		// Token: 0x060052C3 RID: 21187 RVA: 0x00208DC8 File Offset: 0x00206FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightReadyRequest()
		{
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00208DD8 File Offset: 0x00206FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightReadyRequest(FightReadyRequest other)
		{
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00208DE8 File Offset: 0x00206FE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightReadyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x060052C6 RID: 21190 RVA: 0x00208DF8 File Offset: 0x00206FF8
		// (set) Token: 0x060052C7 RID: 21191 RVA: 0x00208E08 File Offset: 0x00207008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
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

		// Token: 0x060052C8 RID: 21192 RVA: 0x00208E18 File Offset: 0x00207018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00208E28 File Offset: 0x00207028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightReadyRequest other)
		{
			return true;
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00208E38 File Offset: 0x00207038
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00208E48 File Offset: 0x00207048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00208E58 File Offset: 0x00207058
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00208E68 File Offset: 0x00207068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00208E78 File Offset: 0x00207078
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00208E88 File Offset: 0x00207088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightReadyRequest other)
		{
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00208E98 File Offset: 0x00207098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00208EA8 File Offset: 0x002070A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00208EB8 File Offset: 0x002070B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightReadyRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						FightReadyRequest._parser = new MessageParser<FightReadyRequest>(() => null);
						num2 = 4;
						continue;
					case 4:
						return;
					}
					break;
				}
				IL_AC:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
				continue;
				goto IL_AC;
			}
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00208F88 File Offset: 0x00207188
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tUlG3WOPSEuqDThNFmNp()
		{
			return true;
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00208F90 File Offset: 0x00207190
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightReadyRequest KnfCdjOPMeooJqEQ2Ddo()
		{
			return null;
		}

		// Token: 0x04001D24 RID: 7460
		private static readonly MessageParser<FightReadyRequest> _parser;

		// Token: 0x04001D25 RID: 7461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D26 RID: 7462
		public const int IsReadyFieldNumber = 1;

		// Token: 0x04001D27 RID: 7463
		private bool isReady_;

		// Token: 0x04001D28 RID: 7464
		private static FightReadyRequest YiZpiVOPPFtVebxY8cJd;
	}
}
