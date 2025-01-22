using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B31 RID: 2865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutSpell : IMessage<ShortcutSpell>, IMessage, IEquatable<ShortcutSpell>, IDeepCloneable<ShortcutSpell>, IBufferMessage
	{
		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06008908 RID: 35080 RVA: 0x002669DC File Offset: 0x00264BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutSpell> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06008909 RID: 35081 RVA: 0x002669EC File Offset: 0x00264BEC
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

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x0600890A RID: 35082 RVA: 0x002669FC File Offset: 0x00264BFC
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

		// Token: 0x0600890B RID: 35083 RVA: 0x00266A0C File Offset: 0x00264C0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutSpell()
		{
		}

		// Token: 0x0600890C RID: 35084 RVA: 0x00266A1C File Offset: 0x00264C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutSpell(ShortcutSpell other)
		{
		}

		// Token: 0x0600890D RID: 35085 RVA: 0x00266A2C File Offset: 0x00264C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutSpell Clone()
		{
			return null;
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x0600890E RID: 35086 RVA: 0x00266A3C File Offset: 0x00264C3C
		// (set) Token: 0x0600890F RID: 35087 RVA: 0x00266A4C File Offset: 0x00264C4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x00266A5C File Offset: 0x00264C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x00266A6C File Offset: 0x00264C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutSpell other)
		{
			return true;
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x00266A7C File Offset: 0x00264C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x00266A8C File Offset: 0x00264C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x00266A9C File Offset: 0x00264C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x00266AAC File Offset: 0x00264CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x00266ABC File Offset: 0x00264CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x00266ACC File Offset: 0x00264CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutSpell other)
		{
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x00266ADC File Offset: 0x00264CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x00266AEC File Offset: 0x00264CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x00266AFC File Offset: 0x00264CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutSpell()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ShortcutSpell._parser = new MessageParser<ShortcutSpell>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x00266BE0 File Offset: 0x00264DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y34XmQJdEHDCDDFOnJIr()
		{
			return true;
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x00266BE8 File Offset: 0x00264DE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutSpell nWgt5rJdXXg7iawPOA5n()
		{
			return null;
		}

		// Token: 0x04003282 RID: 12930
		private static readonly MessageParser<ShortcutSpell> _parser;

		// Token: 0x04003283 RID: 12931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003284 RID: 12932
		public const int SpellIdFieldNumber = 1;

		// Token: 0x04003285 RID: 12933
		private int spellId_;

		// Token: 0x04003286 RID: 12934
		private static ShortcutSpell jKroB7Jd2wkNIgDf5tnu;
	}
}
