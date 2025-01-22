using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x0200069F RID: 1695
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightOptionToggleRequest : IMessage<FightOptionToggleRequest>, IMessage, IEquatable<FightOptionToggleRequest>, IDeepCloneable<FightOptionToggleRequest>, IBufferMessage
	{
		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x060052A6 RID: 21158 RVA: 0x00208B6C File Offset: 0x00206D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightOptionToggleRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x060052A7 RID: 21159 RVA: 0x00208B7C File Offset: 0x00206D7C
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

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x060052A8 RID: 21160 RVA: 0x00208B8C File Offset: 0x00206D8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x00208B9C File Offset: 0x00206D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionToggleRequest()
		{
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00208BAC File Offset: 0x00206DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionToggleRequest(FightOptionToggleRequest other)
		{
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00208BBC File Offset: 0x00206DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightOptionToggleRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x00208BCC File Offset: 0x00206DCC
		// (set) Token: 0x060052AD RID: 21165 RVA: 0x00208BE0 File Offset: 0x00206DE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightOption Option
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightOption)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x00208BF0 File Offset: 0x00206DF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x00208C00 File Offset: 0x00206E00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightOptionToggleRequest other)
		{
			return true;
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00208C10 File Offset: 0x00206E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00208C20 File Offset: 0x00206E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x00208C30 File Offset: 0x00206E30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00208C40 File Offset: 0x00206E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00208C50 File Offset: 0x00206E50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00208C60 File Offset: 0x00206E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightOptionToggleRequest other)
		{
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x00208C70 File Offset: 0x00206E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00208C80 File Offset: 0x00206E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x00208C90 File Offset: 0x00206E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightOptionToggleRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					FightOptionToggleRequest._parser = new MessageParser<FightOptionToggleRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00208D88 File Offset: 0x00206F88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NC9TB6OPbilevfAPjQco()
		{
			return true;
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x00208D90 File Offset: 0x00206F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightOptionToggleRequest dfAXCMOPikItnxqnGND3()
		{
			return null;
		}

		// Token: 0x04001D1D RID: 7453
		private static readonly MessageParser<FightOptionToggleRequest> _parser;

		// Token: 0x04001D1E RID: 7454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D1F RID: 7455
		public const int OptionFieldNumber = 1;

		// Token: 0x04001D20 RID: 7456
		private FightOption option_;

		// Token: 0x04001D21 RID: 7457
		private static FightOptionToggleRequest l9KAw8OPY08s2BxkXXOG;
	}
}
