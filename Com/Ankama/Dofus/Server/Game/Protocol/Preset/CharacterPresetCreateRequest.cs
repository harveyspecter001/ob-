using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000208 RID: 520
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetCreateRequest : IMessage<CharacterPresetCreateRequest>, IMessage, IEquatable<CharacterPresetCreateRequest>, IDeepCloneable<CharacterPresetCreateRequest>, IBufferMessage
	{
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x001AE11C File Offset: 0x001AC31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetCreateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x001AE12C File Offset: 0x001AC32C
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

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x001AE13C File Offset: 0x001AC33C
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

		// Token: 0x06001856 RID: 6230 RVA: 0x001AE14C File Offset: 0x001AC34C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCreateRequest()
		{
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x001AE15C File Offset: 0x001AC35C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCreateRequest(CharacterPresetCreateRequest other)
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x001AE16C File Offset: 0x001AC36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCreateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x001AE17C File Offset: 0x001AC37C
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x001AE18C File Offset: 0x001AC38C
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x001AE19C File Offset: 0x001AC39C
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x001AE1AC File Offset: 0x001AC3AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SymbolId
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

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x001AE1BC File Offset: 0x001AC3BC
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x001AE1CC File Offset: 0x001AC3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetOrigin Origin
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

		// Token: 0x0600185F RID: 6239 RVA: 0x001AE1DC File Offset: 0x001AC3DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x001AE1EC File Offset: 0x001AC3EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetCreateRequest other)
		{
			return true;
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x001AE1FC File Offset: 0x001AC3FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x001AE20C File Offset: 0x001AC40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x001AE21C File Offset: 0x001AC41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x001AE22C File Offset: 0x001AC42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x001AE23C File Offset: 0x001AC43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x001AE24C File Offset: 0x001AC44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetCreateRequest other)
		{
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x001AE25C File Offset: 0x001AC45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x001AE26C File Offset: 0x001AC46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x001AE27C File Offset: 0x001AC47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetCreateRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					CharacterPresetCreateRequest._parser = new MessageParser<CharacterPresetCreateRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x001AE360 File Offset: 0x001AC560
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HP8FerOaOZbZoCOShJgR()
		{
			return true;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x001AE368 File Offset: 0x001AC568
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetCreateRequest swYtvWOaJyinLulA3wla()
		{
			return null;
		}

		// Token: 0x040008A7 RID: 2215
		private static readonly MessageParser<CharacterPresetCreateRequest> _parser;

		// Token: 0x040008A8 RID: 2216
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008A9 RID: 2217
		public const int NameFieldNumber = 1;

		// Token: 0x040008AA RID: 2218
		private string name_;

		// Token: 0x040008AB RID: 2219
		public const int SymbolIdFieldNumber = 2;

		// Token: 0x040008AC RID: 2220
		private int symbolId_;

		// Token: 0x040008AD RID: 2221
		public const int OriginFieldNumber = 3;

		// Token: 0x040008AE RID: 2222
		private PresetOrigin origin_;

		// Token: 0x040008AF RID: 2223
		private static CharacterPresetCreateRequest DNrmZqOaRMfVfBI4y4Ys;
	}
}
